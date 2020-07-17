import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-alunos',
  templateUrl: './alunos.component.html',
  styleUrls: ['./alunos.component.css']
})
export class AlunosComponent implements OnInit {

  titulo = 'Lista de Alunos';

  public alunoSelecionado: string;

  public alunos = [
    { id: 1, nome: 'Cristiane', sobrenome: 'Justo', telefone: 693854},
    { id: 2, nome: 'Eu' ,       sobrenome: 'Basco', telefone: 693854},
    { id: 3, nome: 'Maria',     sobrenome: 'Tutta', telefone: 693854},
    { id: 4, nome: 'Lais',      sobrenome: 'Bucca', telefone: 693854},
    { id: 5, nome: 'João',      sobrenome: 'Linma', telefone: 693854},
    { id: 6, nome: 'Paulo',     sobrenome: 'Rikery', telefone: 693854},
    { id: 7, nome: 'Raul',      sobrenome: 'Juvent', telefone: 693854},
  ];

  alunoSelect(aluno: any)  {
    this.alunoSelecionado = aluno.nome;
  }

  voltar() {
    this.alunoSelecionado = '';
  }

  constructor() { }

  ngOnInit(): void {
  }

}
