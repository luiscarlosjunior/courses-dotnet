import { Component, OnInit, TemplateRef } from '@angular/core';
import { Professor } from '../models/professor';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Aluno } from '../models/Aluno';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-professores',
  templateUrl: './professores.component.html',
  styleUrls: ['./professores.component.css']
})
export class ProfessoresComponent implements OnInit {

  public professorForm: FormGroup;
  public titulo = 'Professores';
  public professorSelecionado: Professor;
  public modalRef: BsModalRef;

  professores = [
    {id: 1, nome : 'Julio', disciplina: 'Computação'},
    {id: 2, nome : 'Romeu', disciplina: 'Arquitetura'},
    {id: 3, nome : 'Claudia', disciplina: 'Lógica'},
    {id: 4, nome : 'José', disciplina: 'Banco de dados'},
    {id: 5, nome : 'Lais', disciplina: 'Java'},
    {id: 6, nome : 'Amanda', disciplina: 'Matlab'},
    {id: 7, nome : 'Luis', disciplina: 'Análise de dados'}
  ];

  constructor(private fb: FormBuilder, private modalService: BsModalService) {
    this.criarForm();
   }

  ngOnInit(): void {
  }

  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template);
  }

  professorSubmit() {
    console.log(this.professorForm.value);
  }

  criarForm() {
    this.professorForm = this.fb.group({
      nome: ['', Validators.required],
      disciplina: ['', Validators.required]
    });
  }

  professorSelect(professor: Professor) {
    this.professorSelecionado = professor;
    this.professorForm.patchValue(professor);
  }

  voltar() {
    this.professorSelecionado = null;
  }

}
