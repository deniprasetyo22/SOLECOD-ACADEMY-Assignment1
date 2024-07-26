// See https://aka.ms/new-console-template for more information

using Assignment1;

Library library = new Library();
library.AddBook(new Book("Pengantar Informatika", "Deni", 2020));
library.AddBook(new Book("Cara Cepat Belajar C#", "Nizar", 2021));
library.AddBook(new Book("Belajar HTML", "Pandi", 2022));
library.AddBook(new Book("Belajar HTML", "Pandi", 2022));

library.DisplayBooks();

library.RemoveBook("Belajar HTML");

library.RemoveBook("Belajar HTML");

library.DisplayBooks();

