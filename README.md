# My Perpus

## Overview
Brief description of your desktop application using .NET.

## Table of Contents
- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Configuration](#configuration)
- [Contributing](#contributing)
- [License](#license)

## Features
- Manage Books
- Manage Student
- Manage Book Loan
- Manage Book Return

## Prerequisites
Make sure you have the following installed before running the application:
- .NET SDK (4.8.1)
- Visual Studio Community 2022 (17.8.3)
- Azure Identity (1.10.14)
- FontAwesome.Sharp (6.3.0)
- Microsoft.EntityFrameworkCore (8.0.1)
- Microsoft.EntityFrameworkCore.Design (8.0.1)
- Microsoft.EntityFrameworkCore.SqlServer (8.0.1)
- Microsoft.Extensions.DepedencyInjection (8.0.0)
- SQL Server 2022
- SQL Server Management Studio 19
- SQL Server 2022 Management Configuration

## Installation
1. Clone the repository.
    ```bash
    git clone https://github.com/feriksan/MyPerpus.git
    ```
2. Navigate to the project directory.
    ```bash
    cd MyPerpus
    ```
3. Migrate Database
    ```bash
    dotnet ef database update
    ```
4. Run the application.
    ```bash
    dotnet run
    ```

## Usage
Explain how to use your application. Provide examples and usage scenarios.

### Manage User
Add user by inputing NIM, Nama, Jurusan, No. HP, and Alamat on the field. You can update and delete user data by clicking Edit and Delete button inside the table row of the data you want to modified. By clicking the edit button, the student data will show on the input field, by clicking edit, you will update the data with coresponding NIM.

![alt text](http://url/to/img.png)

### Manage Book
Add book by inputing Judul, Penulis, Penerbit, and Tahun on the field. You can update and delete book data by clicking Edit and Delete button inside the table row of the data you want to modified. By clicking the edit button, the book data will show on the input field, by clicking edit, you will update the data with coresponding Kode Buku.

![alt text](http://url/to/img.png)

### Manage Book Loan
Register book loan by inputing Kode Buku, NIM, Tanggal Pinjam, and Lama Pinjam on the field. 

![alt text](http://url/to/img.png)

### Manage Book Return
Register book return by inputing Kode Buku, NIM, Jatuh Tempo, Tanggal Pinjam, Tanggal Kembali, Denda, Total Denda, and Lama Pinjam on the field. 

![alt text](http://url/to/img.png)

## Configuration
Configure your sql database by modifying dataContext _connectionString
 ```bash
    Server=[your_sql_server_host];Initial Catalog=[your_database];User ID=[your_user];Password=[your_user_password];Trust Server Certificate=True;
 ```


