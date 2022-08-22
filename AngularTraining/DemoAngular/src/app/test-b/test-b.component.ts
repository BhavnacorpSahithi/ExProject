import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-test-b',
  templateUrl: './test-b.component.html',
  styleUrls: ['./test-b.component.css']
})
export class TestBComponent implements OnInit {
  TestDataB: string = '';
  constructor() { }

  ngOnInit(): void {
    this.sampleDataBinding();
  }

  sampleDataBinding(){
    this.TestDataB = 'test-B component data using interpolation';
  }

}
