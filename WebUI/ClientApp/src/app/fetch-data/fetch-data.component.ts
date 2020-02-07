import { Component, Inject } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { EmployeeService, Employee } from "../api-generated";

@Component({
  selector: "app-fetch-data",
  templateUrl: "./fetch-data.component.html"
})
export class FetchDataComponent {
  public werknemers: Employee[] = [];

  constructor(private service: EmployeeService) {
    service.getAllEmployees().subscribe(response => {
      this.werknemers = response;
      console.log(response);
    });
  }
}
