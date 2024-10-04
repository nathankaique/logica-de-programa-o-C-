using System;


//calculando o sálario com comissão
//dados o salário fixo e o valor total de vendas efetuadas por um vendedor
//sabendo que ele recebe 5% de comissão sobre o valor total de vendas até 2.000,00 e mais 10% sobre o que ultrapassar esse valor
//calcular e exibir o valor total

decimal salarioFixo = 3000;
decimal totalVendas = 1900;
decimal comissao = 0;

if(totalVendas > 2000){
    comissao = (totalVendas - 2000) * 0.1m;
    comissao = comissao + (2000 * 0.05m);
    }
else{
    comissao = totalVendas * 0.05m;
}
Console.WriteLine($"o salário total é: {comissao + salarioFixo}");