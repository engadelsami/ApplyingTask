export  class GetComplainsModel{
  Id :number;
  ComplainType:string;
  ComplainDate:Date;
  City:string ;
  Department:string;
  Status:string;
  Display:string;
  constructor(id:number, complainType:string,city : string,complainDate: Date,department:string,status:string,display:string)
  {
   this.Id=id;
   this.ComplainType=complainType;
   this.ComplainDate=complainDate;
   this.City=city;
   this.Department=department;
   this.Status=status;
  this.Display=display;
  }

  }
