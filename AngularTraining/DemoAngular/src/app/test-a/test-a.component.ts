import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-test-a',
  templateUrl: './test-a.component.html',
  styleUrls: ['./test-a.component.css']
})
export class TestAComponent implements OnInit {
  TestDataA: string = '';

  constructor() { }

  ngOnInit(): void {
    this.sampleDataBinding();
  }

  sampleDataBinding(){
    this.TestDataA = 'test-A component data using interpolation';
  }
}
