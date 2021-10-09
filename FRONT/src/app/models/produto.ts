import { Categoria } from "./categoria";

export interface Produto {
    id?: number;
    nome : string;
    descricao: string;
    quantidade: number;
    preco: number;
    criadoem?: number;
    categoriaId: number;
    categoria?: Categoria;
}
