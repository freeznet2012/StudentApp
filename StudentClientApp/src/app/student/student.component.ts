import { Component, OnInit } from '@angular/core';
import { IStudent } from './student.interface';
import { StudentService } from './student.service';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {

  students: Array<IStudent> = [];
  showResultsOfAll = false;
  showMarksAfterGrace = false;

  constructor(private service: StudentService) { }

  ngOnInit(): void {
    this.service.getStudents().subscribe(data => {
      this.students = data;
      this.setResults();
    });
  }

  private setResults() {
    this.students.forEach(student => {
      const failedExams = student.marks.filter(mark => mark < 30);
      const markDeficit = 60 - failedExams.reduce((a, b) => a + b, 0);
      const countOfFailedExams = failedExams.length;
      student.result = countOfFailedExams == 0;

      if (countOfFailedExams > 0 && countOfFailedExams <= 2 && markDeficit <= 6) {
        student.marksAfterGrace = [];
        student.marks.forEach(mark => {
          student.marksAfterGrace.push(mark < 30 ? 30 : mark);
        });
        student.totalAfterGrace = student.total + markDeficit;
        student.resultAfterGrace = true;
      } else {
        student.marksAfterGrace = [...student.marks];
        student.totalAfterGrace = student.total;
        student.resultAfterGrace = student.result;
      }
    });
  }

}
