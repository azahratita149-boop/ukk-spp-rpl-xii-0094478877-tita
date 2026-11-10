<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;
return new class extends Migration
{
    /**
     * Run the migrations.
     */
    public function up(): void
    {
        Schema::create('petugas', function (Blueprint $table) {
            $table->integer(id_petugas)->int();
            $table->string('username')->varchar(30);
            $table->string('password')->varchar(30);
            $table->string('nama_petugas')->varchar(30);
            $table->string('level')->enum();
            $table->timestamp();
        });
    }
}


