﻿using System.ComponentModel.DataAnnotations;
using ToDoList.Domain.Entities;

namespace ToDoList.Mvc.Models.Home
{
    public class HomeViewModel
    {
        [Required(ErrorMessage = "Данное поле обязательно")]

        public string TaskName { get; set; }

        [Required(ErrorMessage = " Данное поле обязательно")]

        public DateTime? DateTime { get; set; }

        public IEnumerable<TaskApp>? Tasks { get; set; }
    }
}
