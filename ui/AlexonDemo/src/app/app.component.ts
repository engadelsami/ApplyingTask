import { Component, OnInit } from '@angular/core';
import { GetComplainsModel } from './Models/GetComplainsModel';
import { ComplainService } from './Service/complain.service';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'AlexonDemo';
  complains:any;
  constructor(private service: ComplainService) { }
  data :any;
  //data: GetComplainsModel[] = [];

  ngOnInit(): void {
    this.service.GetComplains().subscribe(e => {
      console.log("res", JSON.stringify(e));
      this.data = e;
      console.log("data____", this.data);

    });
  }
}
