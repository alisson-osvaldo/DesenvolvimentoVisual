import { ProdutoService } from './services/produto.service';
import { Component, OnInit } from '@angular/core';
import { Produto } from './models/produto';


@Component({
    selector: "app-root",
    templateUrl: "./app.component.html",
    styleUrls: [],
})
export class AppComponent implements OnInit{
    //variavel global
    produtos: Produto[] = [];
 //ddeve ser inicializada usando: = [] ou  produto! para informar q não vai ser inicializado

    constructor(private service: ProdutoService) {}

    ngOnInit(): void {
        this.service.list().subscribe((produtos) => {
            this.produtos = produtos;
            console.log(produtos);
        });

    }
}
