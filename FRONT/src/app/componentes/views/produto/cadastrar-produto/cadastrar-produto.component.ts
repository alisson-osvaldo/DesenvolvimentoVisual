import { ProdutoService } from 'src/app/services/produto.service';
import { Produto } from 'src/app/models/produto';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-cadastrar-produto',
  templateUrl: './cadastrar-produto.component.html',
  styleUrls: ['./cadastrar-produto.component.css']
})
export class CadastrarProdutoComponent implements OnInit {
    nome!:         string;
    descricao!:   string;
    quantidade!: number;
    preco!:          number;

  constructor(private router: Router, private service: ProdutoService) { }

  ngOnInit(): void {
  }

  cadastrar( ): void{
      let produto: Produto = {
          nome: this.nome,
          descricao: this.descricao,
          preco: this.preco,
          quantidade: this.quantidade,
      }
      this.service.create(produto).subscribe((produto) => {
        console.log(produto);
        this.router.navigate(["produto/listar"]);
     });
  }
}
