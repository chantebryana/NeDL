import { Injectable } from '@angular/core';
import { Camera, CameraResultType, CameraSource, Photo } from '@capacitor/camera';
import { Filesystem, Directory } from '@capacitor/filesystem';
import { Storage } from '@capacitor/storage';

@Injectable({
  providedIn: 'root'
})
export class PhotoService {
  //define variables
  public photos: UserPhoto[] = []; //array contains reference to each photo captured w camera

  //save photo to filesystem
  //pass in photo object, which represents the newly captured image
  private async savePicture(photo: Photo) {
    //convert photo to base64 format, required by filesystem api to save
    const base64Data = await this.readAsBase64(photo);

    //write the file to the new directory
    const fileName = new Date().getTime() + '.jpeg';
    const savedFile = await Filesystem.writeFile({
      path: fileName,
      data: base64Data,
      directory: Directory.Data
    });
    // Use webPath to display the new image instead of base64 since it's
    // already loaded into memory
    return {
      filepath: fileName,
      webviewPath: photo.webPath
    };
  }

  //helper function readAsBase64
  //requires small amount of platform-specific logic (web v mobile)
  private async readAsBase64(photo: Photo) {
    //fetch the photo, read as a blob, then convert to base64 format
    const response = await fetch(photo.webPath!);
    const blob = await response.blob();

    return await this.convertBlobToBase64(blob) as string;
  }

  private convertBlobToBase64 = (blob: Blob) => new Promise((resolve, reject) => {
    const reader = new FileReader();
    reader.onerror = reject;
    reader.onload = () => {
      resolve(reader.result);
    };
    reader.readAsDataURL(blob);
  });

  constructor() { }

  public async addNewToGallery() {
    // Take a photo
    const capturedPhoto = await Camera.getPhoto({
      resultType: CameraResultType.Uri, // file-based data; provides best performance
      source: CameraSource.Camera, // automatically take a new photo with the camera
      quality: 100 // highest quality (0 to 100)
    });

    //add newly captured photo to beginning of photos array
    this.photos.unshift({
      filepath: "soon...",
      webviewPath: capturedPhoto.webPath
    });

    //save teh picture and add it to photo collection
    const savedImageFile : UserPhoto = await this.savePicture(capturedPhoto); //implied typing
    this.photos.unshift(savedImageFile);
  }

  
}

//outside of photoservice class
//create new interface UserPhoto
//to hold photo metadata
export interface UserPhoto {
  filepath: string;
  webviewPath: string;
}