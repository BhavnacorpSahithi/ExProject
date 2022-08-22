import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-test-b',
  templateUrl: './test-b.component.html',
  styleUrls: ['./test-b.component.css']
})
export class TestBComponent implements OnInit {
  TestDataB: string = '';
  selectedcountry = '';
  Countries :string[]=['India','USA','UK','Afganistan','Bangladesh'];
   india :string[]=['AP','Assam','Bihar','Goa','Gujarat'];
   usa :string[]=['California','Texas','Florida','Virginia','Alaska'];
   uk :string[]=['England','Belfast','Cardiff','Edinburgh','London'];
   afganistan :string[]=['kabul','Kandahar','Kapisa','Khost','Parwan'];
   bnagladesh :string[]=['Barisal','chittagong','Dhaka','Kulna','Bengali'];

  constructor() { }

  ngOnInit(): void {
    this.sampleDataBinding();
  }

  sampleDataBinding(){
    this.TestDataB = 'test-B component data using interpolation';
  }
  getselected(event:any){
    this.selectedcountry = event.target.value;
  }

}
