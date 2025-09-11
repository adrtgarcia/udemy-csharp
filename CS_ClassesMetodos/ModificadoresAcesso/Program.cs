using ModificadoresAcesso;

Console.WriteLine("Modificadores de Acesso");

/* 
 
    public: 
        pode ser acessado por qualquer outro código no mesmo/em outro assembly
    private:
        pode ser acessado somente pelo código da classe/struct
    internal:
        pode ser acessado por qualquer outro código no mesmo assembly
    protected:
        pode ser acessado por qualquer outro código no mesmo assembly ou classe derivada
    file:
        restringe o escopo e a visibilidade de um tipo de nível superior ao arquivo onde foi declarado
    há ainda:
        protected internal, private protected
 */

MinhaClasse mc = new();
// mc. <- sem acesso aos membros

MinhaStruct ms = new();
// ms. <- sem acesso aos membros

MinhaEnum me = new();
// me. <- sem acesso aos membros, mas MinhaEnum consegue acessar
Console.WriteLine(MinhaEnum.opcao1);
Console.WriteLine(MinhaEnum.opcao3);