﻿using UseStringBuilder.Entities;

Comment c1 = new("Have a nice trip!");
Comment c2 = new("Wow that's awesome!");

Post p1 = new(
    DateTime.Parse("21/06/2018 13:05:44"),
    "Traveling to New Zealand",
    "I'm going to visit this wonderful country!",
    12);

p1.AddComment(c1);
p1.AddComment(c2);

Comment c3 = new("Good night");
Comment c4 = new("May the Force be with you");

Post p2 = new(
    DateTime.Parse("24/08/2020 11:06:42"),
    "Good night guys",
    "See you tomorrow",
    5);

p2.AddComment(c3);
p2.AddComment(c4);

Console.WriteLine(p1);
Console.WriteLine(p2);