import { CommonModule, NgIf } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { error } from 'console';
import { response } from 'express';

/*
  -- Problema do ngfor colocando 

  imports: [CommonModule],
  template: `<div *ngIf="visible">Hi</div>`,

*/
@Component({
  selector: 'app-eventos',
  standalone: true,
  imports: [CommonModule],
  template: `<div *ngIf="visible">Hi</div>`,
  templateUrl: './eventos.component.html',
  styleUrl: './eventos.component.scss'
})
export class EventosComponent {
  public eventos: any;

  constructor(private http:HttpClient){ }
  
  ngOnInit(): void {
    this.getEventos();
  }

  public getEventos() : void {
    this.http.get('https://localhost:5001/api/eventos').subscribe(
      response => this.eventos = response,
      error => console.log(error)
    );
    // this.eventos = [
    //   {
    //     Tema : 'Angular',
    //     Local : 'Lucelia'
    //   },
    //   {
    //     Tema : 'Angular1',
    //     Local : 'Lucelia1'
    //   },
    //   {
    //     Tema : 'Angular2',
    //     Local : 'Lucelia2'
    //   },
      
      
    // ];
  }


}
