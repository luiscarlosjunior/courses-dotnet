import { Component, OnInit, TemplateRef } from '@angular/core';
import { Aluno } from '../models/Aluno';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-alunos',
  templateUrl: './alunos.component.html',
  styleUrls: ['./alunos.component.css']
})
export class AlunosComponent implements OnInit {

  titulo = 'Lista de Alunos';

  public alunoForm: FormGroup;
  public alunoSelecionado: Aluno;
  public textSimple: string;
  public modalRef: BsModalRef;

  public alunos = [
    { id: 1, nome: 'Cristiane', sobrenome: 'Justo', telefone: 693854},
    { id: 2, nome: 'Eu' ,       sobrenome: 'Basco', telefone: 693854},
    { id: 3, nome: 'Maria',     sobrenome: 'Tutta', telefone: 693854},
    { id: 4, nome: 'Lais',      sobrenome: 'Bucca', telefone: 693854},
    { id: 5, nome: 'João',      sobrenome: 'Linma', telefone: 693854},
    { id: 6, nome: 'Paulo',     sobrenome: 'Rikery', telefone: 693854},
    { id: 7, nome: 'Raul',      sobrenome: 'Juvent', telefone: 693854},
  ];

  constructor(private fb: FormBuilder, private modalService: BsModalService) {
    this.criarForm();
  }

  ngOnInit(): void {
  }

  criarForm() {
    this.alunoForm = this.fb.group({
      nome: ['', Validators.required],
      sobrenome: ['', Validators.required],
      telefone: ['', Validators.required]
    });
  }

  alunoSubmit() {
    console.log(this.alunoForm.value);
  }

  alunoSelect(aluno: Aluno)  {
    this.alunoSelecionado = aluno;
    this.alunoForm.patchValue(aluno);
  }

  voltar() {
    this.alunoSelecionado = null;
  }

  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template);
  }

}
