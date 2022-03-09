int op;
do
{
    Console.Clear();
    Console.WriteLine("**********MENU PRINCIPAL**********");
    Console.WriteLine("1-CADASTRAR PRODUTO");
    Console.WriteLine("2-MOSTRAR PRODUTO");
    Console.WriteLine("3-ALTERAR PRODUTO");
    Console.WriteLine("4-EXCLUIR PRODUTO");
    Console.WriteLine("5-SAIR DO SISTEMA");
    Console.Write("Escolha a opção desejada: ");

    op = int.Parse(Console.ReadLine());

    //Console.WriteLine("Opção escolhida:  " + op);

    switch (op)
    {
        case 1:
            Console.WriteLine("***Cadastrado com êxito***");
            Console.Write("precione qualque tecla para retornar: ");
            Console.ReadLine();
            break;

        case 2:
            Console.WriteLine("***Aqui está seu produto***");
            Console.Write("precione qualque tecla para retornar: ");
            Console.ReadLine();
            break;

        case 3:
            Console.WriteLine("***produto alterado***");
            Console.Write("precione qualque tecla para retornar: ");
            Console.ReadLine();
            break;

        case 4:
            Console.WriteLine("***Produto excluido***");
            Console.Write("precione qualque tecla para retornar: ");
            Console.ReadLine();
            break;

        case 5:
            Console.WriteLine("finalizando o sistema");
            break;

        default:
            Console.WriteLine("comando invalido");
            Console.Write("precione qualque tecla para retornar: ");
            Console.ReadLine();
            break;

    }
}while(op != 5);