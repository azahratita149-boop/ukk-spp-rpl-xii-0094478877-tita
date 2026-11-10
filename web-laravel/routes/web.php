<?php

use App\Http\Controllers\AuthController;
use Illuminate\Support\Facades\Route;

Route::get('login', function () {
    return view('welcome');
});

route::get('/formlogin',[AuthController::class]);
