import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import {Student} from '../models/Student';
import { HttpClient } from '@angular/common/http';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-add-student',
  templateUrl: './add-student.component.html',
  styleUrls: ['./add-student.component.css']
})
export class AddStudentComponent implements OnInit {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, 
  private _router: Router) { }

  ngOnInit() {
  }

  studentForm = new FormGroup({
    // I attempted to add Validators but sadly got confused.
    // Would've liked to have this typed somehow to Student
    firstName: new FormControl(''),
    lastName: new FormControl(''),
    email: new FormControl(''),
    major: new FormControl(''),
    averageGrade: new FormControl(''),
  });

  onSubmit() {
    const newStudent = (this.studentForm.value as Student);
    this.http.post(this.baseUrl + "students", newStudent)
      .subscribe({
        next: (response) => response ? this._router.navigate([""]):console.log("oops"),
        error: (error) => console.log(error),
      });

  }

}
