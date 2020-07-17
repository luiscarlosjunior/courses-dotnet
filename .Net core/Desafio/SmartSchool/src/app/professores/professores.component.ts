import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-professores',
  templateUrl: './professores.component.html',
  styleUrls: ['./professores.component.css']
})
export class ProfessoresComponent implements OnInit {

  titulo = 'Professores';
  public professorSelecionado: string;
  professores = [
    {id: 1, nome : 'Julio', disciplina: 'Computação'},
    {id: 2, nome : 'Romeu', disciplina: 'Arquitetura'},
    {id: 3, nome : 'Claudia', disciplina: 'Lógica'},
    {id: 4, nome : 'José', disciplina: 'Banco de dados'},
    {id: 5, nome : 'Lais', disciplina: 'Java'},
    {id: 6, nome : 'Amanda', disciplina: 'Matlab'},
    {id: 7, nome : 'Luis', disciplina: 'Análise de dados'}
  ];

  professorSelect(professor: any) {
    this.professorSelecionado = professor.nome;
  }

  voltar() {
    this.professorSelecionado = '';
  }

  constructor() { }

  ngOnInit(): void {
  }

}
