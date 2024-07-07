import { Component, EventEmitter, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  @Output() cancelRegistration = new EventEmitter();
  model: any = {};


  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }

  register() {
    console.log(this.model);
  }

  cancel(){
    this.cancelRegistration.emit(false);
  }

}
