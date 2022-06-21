import { Component, OnInit } from '@angular/core';
import { BackendService } from '../backend.service';
import { ShoppingListItem } from '../IShoppingListItem';

@Component({
  selector: 'app-my-list',
  templateUrl: './my-list.component.html',
  styleUrls: ['./my-list.component.css']
})

//Modify the component TypeScript to call the backend service to get the dat.
export class MyListComponent implements OnInit {
  shoppingList: ShoppingListItem[] | undefined;

  constructor(private backend: BackendService) { }

  async ngOnInit() {
    this.shoppingList = await this.backend.shoppingList();
    console.log(this.shoppingList);
  }

}
