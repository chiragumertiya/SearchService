import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { PersonService } from './PersonService';
import { Person } from './Person';
import { FormsModule } from '@angular/forms';


interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  searchName: string = '';
  searchResults: Person[] = [];
  errorMessage: string = '';

  constructor(private personService: PersonService) {}

  handleSearch(): void {
    if (!this.searchName.trim()) {
      this.errorMessage = 'Search cannot be empty';
      return;
    }

    this.personService.searchPeople(this.searchName)
      .subscribe(
        (results: Person[]) => {
          this.searchResults = results;
          this.errorMessage = '';
        },
        (error) => {
          this.errorMessage = 'An error occurred while fetching data';
          console.error(error);
        }
      );
  }
}
