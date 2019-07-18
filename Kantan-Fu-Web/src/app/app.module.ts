import { RouterModule, Router } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
// Services 
// Material Design Components -> imports
import { MatIconModule } from '@angular/material/icon';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatDividerModule } from '@angular/material/divider';
import { MatMenuModule } from '@angular/material/menu';
import { MatDialogModule } from '@angular/material/dialog';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';

// Components -> imports
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { TestComponent } from './test/test.component';
import { LessonComponent } from './lesson/lesson.component';
import { TopicComponent } from './topic/topic.component';
import { AdminComponent, AdminLoginComponent } from './admin/admin.component';


@NgModule({
  entryComponents: [AdminLoginComponent],
  declarations: [AppComponent, HomeComponent, TestComponent, LessonComponent, TopicComponent, AdminComponent, AdminLoginComponent],
  imports: [
    BrowserAnimationsModule,
    FormsModule,
    HttpClientModule,
    MatIconModule,
    MatToolbarModule,
    MatButtonModule,
    MatCardModule,
    MatGridListModule,
    MatDividerModule,
    MatMenuModule,
    MatDialogModule,
    MatFormFieldModule,
    MatInputModule,

    RouterModule.forRoot([
      { path: '', redirectTo: '/home', pathMatch: 'full' },
      { path: 'home', component: HomeComponent },
      { path: 'tests', component: TestComponent },
      { path: 'lessons', component: LessonComponent },
      { path: 'topics', component: TopicComponent },
      { path: 'admin', component: AdminComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
