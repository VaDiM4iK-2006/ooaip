﻿using System.ComponentModel.DataAnnotations.Schema;

namespace AbstractFactory
{
    public interface IAbstractFactory
    {
        IChair CreateChair();
        ITable CreateTable();
        ISofa CreateSofa();
    }
}
