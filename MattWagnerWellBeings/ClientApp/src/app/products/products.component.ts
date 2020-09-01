import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent {
  public allProducts: Product[];
  public filteredProducts: Product[];
  public types: string[];
  public selectedType: string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.selectedType = "All";

    http.get<Product[]>(baseUrl + 'products').subscribe(result => {
      this.allProducts = result;
      this.filteredProducts = result;
      this.setTypes();
    }, error => console.error(error));
  }

  public selectColumn(column: string) {
    this.selectedType = column;
    if (column === "All") {
      this.filteredProducts = this.allProducts;
    } else {
      this.filteredProducts = this.allProducts.filter(x => x.type === this.selectedType);      
    }
  }

  private setTypes(): void {
    this.types = [];
    this.types.push("All");
    this.allProducts.forEach((product) => {
      if (this.types.indexOf(product.type) === -1) {
        this.types.push(product.type);
      }
    })
  }
}

interface Product {
  id: number;
  name: string;
  type: string;
  description: string;
}

