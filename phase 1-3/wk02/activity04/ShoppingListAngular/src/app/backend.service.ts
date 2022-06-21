import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { firstValueFrom } from 'rxjs';
import { ShoppingListItem } from './IShoppingListItem';

@Injectable({
  providedIn: 'root'
})

//Generate a service for backend communication.
//`ng g s Backend`

//Then modify the backend service backend.service.ts file to return some static fake data.
export class BackendService {

  constructor(private http: HttpClient) { }

  async shoppingList(): Promise<ShoppingListItem[]> {
    return firstValueFrom(
      this.http.get<ShoppingListItem[]>('https://localhost:7090/ShoppingList')
    );
  }

  /*
  async shoppingList(): Promise<ShoppingListItem[]> {
    return new Promise((resolve) => {
      resolve([
        {title: 'Apples'}, 
        {title: 'Sunbutter'},
        {title: 'Chocolate'},
      ] as ShoppingListItem[]);
    });
  }
  */
}
