// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair


// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).
// 1. Declarar variaveis
// 2. Declarar arrays

// ALGORITMO SENHA:
// 1. Entrada da senha (123456);
// 2. Verificação se esta correta ou incorreta;
// 3. Exibir menu com as opções.

String nomeUsuario;
String senha;
String resposta;

int escolherOpcao;
string [] nomes = new string[5];
string [] origem = new string[5];
string [] destino = new string[5];
string [] data = new string[5];

// ALGORITMO SENHA

Console.WriteLine($"Bem-Vindo a AGC Turismo!");
Console.WriteLine($"Informe o nome de usuario: ");
nomeUsuario = Console.ReadLine();

static bool validarSenha(string senha)
{
    if (senha == "123456")
    {
        Console.WriteLine("Login efetuado com sucesso!");
        return true;
    }

    else
    {   
        Console.WriteLine("Senha incorreta, tente novamente!");
        return false;
    }
}

while (true)
{
        Console.WriteLine($"Por favor, informe a sua senha:");
        senha = Console.ReadLine();

    if (validarSenha(senha))
    {
        break;
    }
}
 

while (true)
{
Console.WriteLine(@$"

[--------------------------------------]
            MENU AGC TURISMO        
    Selecione a opção desejada.             
    1 - Cadastrar passagem                
    2 - Listar passagens                         
    0 - Sair                                            
[--------------------------------------]
");

Console.WriteLine($"");

escolherOpcao = int.Parse(Console.ReadLine());
while (escolherOpcao < 0 || escolherOpcao > 2)
    {
        Console.WriteLine("Opção inválida. Tente novamente.");   
        escolherOpcao = int.Parse(Console.ReadLine());
    }

switch (escolherOpcao)
{

case 1:
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{i + 1}º Passageiro ");
    Console.WriteLine("Informe o nome:");
    nomes[i] = Console.ReadLine();

    Console.WriteLine("Informe a origem:");
    origem[i] = Console.ReadLine();

    Console.WriteLine("Informe o destino:");
    destino[i] = Console.ReadLine();

    Console.WriteLine("Informe a data do voo em dd/mm/aaaa:");
    data[i] = Console.ReadLine();

    Console.WriteLine("Passagem cadastrada com sucesso!");
            
    Console.WriteLine("Deseja cadastrar uma nova passagem? (S/N)");
    resposta = Console.ReadLine().ToUpper();
    
    if (resposta != "S")
    {
        break;
    }
    else 
    {
        Console.WriteLine($"Obrigado! Cadastro feito com sucesso :)");
        
    }
}
break;

case 2: 
if (string.IsNullOrEmpty(nomes[0]))
{
    Console.WriteLine("Nenhuma passagem cadastrada ainda.");
}
else
{
    Console.WriteLine("Passagens cadastradas:");
    Console.WriteLine($"");
    
for (var i = 0; i < 5; i++)
{
if (!string.IsNullOrEmpty(nomes[i]))
{
    Console.WriteLine($"Passageiro: {nomes[i]}");
    Console.WriteLine($"Origem: {origem[i]}");
    Console.WriteLine($"Destino: {destino[i]}");
    Console.WriteLine($"Data do voo: {data[i]}");
    Console.WriteLine($@"-------------------------------------");
    
}
}
}
break;

case 0:

    Console.WriteLine("Obrigado! volte sempre.");
    return;

    default:
    Console.WriteLine("Opção inválida, tente novamente!");
    break;
}
}


