import { Component, OnInit, ViewChild } from '@angular/core';
import { DashboardService } from '../dashboard.service';
import { MatTableDataSource, MatPaginator } from '@angular/material';
import { Produto } from '../Models/produto';


const ELEMENT_DATA: Produto[] = [
  { Id: 1, Nome: 'Feijão', Valor: 5.1, Quantidade: 10,Fornecedor: "fornecedor 1" },
  { Id: 1, Nome: 'Arroz', Valor: 4.1, Quantidade: 120,Fornecedor: "fornecedor 1" },
  { Id: 1, Nome: 'Alface', Valor: 3, Quantidade: 124,Fornecedor: "fornecedor 1" },
  { Id: 1, Nome: 'Repolho', Valor: 8.5, Quantidade: 110,Fornecedor: "fornecedor 1" },
  { Id: 1, Nome: 'Couve', Valor: 9.4, Quantidade: 103,Fornecedor: "fornecedor 1" },
  { Id: 1, Nome: 'Lentilha', Valor: 1.5, Quantidade: 10,Fornecedor: "fornecedor 1" },
  { Id: 1, Nome: 'Cenoura', Valor: 2, Quantidade: 101,Fornecedor: "fornecedor 1" },
  { Id: 1, Nome: 'Batata', Valor: 1.0079, Quantidade: 0,Fornecedor: "fornecedor 1" },

];

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {

  bigChart = [];
  cards = [];
  pieChart = [];

  displayedColumns: string[] = ['Id', 'Nome', 'Valor', 'Quantidade','Fornecedor'];
  dataSource_All = new MatTableDataSource<Produto>(ELEMENT_DATA);
  dataSource_Empty = new MatTableDataSource<Produto>(ELEMENT_DATA);
  dataSource_byFornecedor = new MatTableDataSource<Produto>(ELEMENT_DATA);

  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;

  constructor(private dashboardService: DashboardService) { }

  ngOnInit() {
    this.bigChart = this.dashboardService.bigChart();
    this.cards = this.dashboardService.cards();
    this.pieChart = this.dashboardService.pieChart();

    this.dataSource_All.paginator = this.paginator;
    this.dataSource_byFornecedor.paginator = this.paginator;
    this.dataSource_Empty.paginator = this.paginator;
  }

}
