﻿using eCommerce.Office;
using eCommerce.Office.Models;
using Microsoft.EntityFrameworkCore;

var db = new eCommerceOfficeContext();

#region Many-To-Many > 2x One-To-Many
// setor > colaboradorSetor > colaborador

var resultado = db.Setores!
    .Include(setor => setor.ColaboradorSetores)
    .ThenInclude(colaboradorSetor => colaboradorSetor.Colaborador);

foreach (var setor in resultado)
{
    Console.WriteLine(setor.Nome);

    foreach (var colaboradorSetor in setor.ColaboradorSetores)
    {
        Console.WriteLine(" - " + colaboradorSetor.Colaborador.Nome);
    }
}
#endregion

#region Many-To-Many - Com EF Core 5+

var resultadoTurma = db.Colaboradores!.Include(colaborador => colaborador.Turmas);

foreach (var colaborador in resultadoTurma)
{
    Console.WriteLine(colaborador.Nome);

    foreach (var turma in colaborador.Turmas)
    {
        Console.WriteLine("- " + turma.Nome);
    }
}

#endregion
