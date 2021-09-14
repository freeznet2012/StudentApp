import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { HttpClient } from '@angular/common/http';
import { IStudent } from "./student.interface";

@Injectable({
    providedIn: 'root'
})
export class StudentService {
    constructor(private http: HttpClient) { }
    public getStudents(): Observable<Array<IStudent>> {
        return this.http.get<Array<IStudent>>('http://localhost:5000/api/student');
    }
}