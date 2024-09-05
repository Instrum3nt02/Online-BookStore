import { Routes } from '@angular/router';
import { LoginComponent } from './Components/login/login.component';
import { RegisterComponent } from './Components/register/register.component';
import { HomeComponent } from './Components/home/home.component';
import { BookDetailComponent } from './Components/book-detail/book-detail.component';
import { CartComponent } from './Components/cart/cart.component';

export const routes: Routes = [
    {
        path: 'login',
        component : LoginComponent
    },
    {
        path: 'register',
        component : RegisterComponent
    },
    {
        path: '',
        component: HomeComponent
    },
    {
        path:'book-detail',
        component: BookDetailComponent
    },
    {
        path:'cart',
        component: CartComponent
    }
];
