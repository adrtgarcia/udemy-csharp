Console.WriteLine("Exercícios Teóricos");

/*
 
    CLASSE:
        modelo para criar objetos, fornecer valor iniciais para estado (variáveis ou atributos de membro) 
        e implementações de comportamento (funções ou métodos de membro)
    
    OBJETO:
        instância de classe que pode ser usada para acessar métodos de classe, 
        a palvra-chave new pode ser usada para constuir um objeto

    CLASSE X OBJETO:
        classe é o modelo que descreve os objetos e suas características e comportamentos,
        objeto é o modelo personalizado com valores e estado e podem ser categorizados e agrupados
            - objeto materializa a classe

    MÉTODO:
        bloco de código que contém uma série de instruções, que serão executadas pelo programa
        ao chamar o método e especificando argumentos

    PARÂMETRO:
        valor proveniente de uma variável ou expressão mais complexa que representa um valor 
        que o método espera receber quando for chamado
            - possui nome

    ARGUMENTO:
        valor passado para um parâmetro de método quando o método é chamado, assim o código
        de chamada fornece os argmentos quando chama o método
            - não possui nome

    CONSTRUTOR:
        construtor é um método especial com o mesmo nome de sua classe, invocado automaticamente
        quando um objeto é criando e responsável por construir todos os valores dos membros de dados

    THIS:
        palavra-chave que se refere à instância atual da classe e pode ser usada para passar um objeto 
        da instância atual para outros métodos, invocar outros construtor da mesma classe ou da classe base

    MÉTODO COM RETORNO:
        para métodos não-void, a palavra-chave RETURN é usada para retornar um valor, podendo
        ser utilizada também para interromper a execução do método

    SOBRECARGA DE MÉTODO:
        processo de gerar muitos métodos na mesma classe com o mesmo nome, mas assinaturas diferentes
            - compilador utiliza resolução de sobrecarga para identificar qual método invocar

    PASSAGEM DE PARÂMETROS POR VALOR:
        o método que tem um parâmetro de um tipo de valor, ao ser executado, recebe uma cópia do argumento
        e o valor original da variável não é alterado

    PASSAGEM DE PARÂMETROS POR REFERÊNCIA:
        o método que tem um parâmetro de um tipo de referência, ao ser executado, recebe uma referência ao
        argumento, ou seja, o endereço de memória da variável, que terá seu valor original alterado

    OUT X REF:
        quando um argumento é passado como REF, ele deve ser inicializado antes de poder ser passado 
        para o método, já um parâmetro OUT não precisa ser inicializado antes

    ARGUMENTOS NOMEADOS:
        permitem a especificação de um argumento para um parâmetro correspondendo o argumento com seu nome,
        ao invés da sua posição na lista de parâmetros

    PARÂMETROS OPCIONAIS:
        podem ser omitidos na chamada do método, recebendo um valor padrão pré-definido
            - são definidos no final da lista de parâmetros, após os obrigatórios

    STATIC:
        significa "relativo ao próprio tipo, em vez de ums instância do tipo", e permite o acesso
        de um membro estático usando o nome do tipo em vez de uma referência ou um valor

    MÉTODO ESTÁTICO:
        mantém apenas uma cópia do método no níel do tipo, não no nível do objeto, 
        o que significa que todas as instâncias da classe compartilham a mesma cópia do método e seus dados
    
    CAMPO ESTÁTICO:
        declaração de uma variável que será mantida em comum por todas as instância de uma classe
 
    PROPRIEDADES:
        se comportam como campos quando são acessadas, no entanto são implementadas como acessadores (get/set)
        que definem as instruções executadas quando uma propriedade é acessada ou atribuída
            - permitem encapsular os atributos da classe

    CAMPO X PROPRIEDADE:
        uma propriedade expõe um campo, assim (quase sempre) os campos devem ser privados para uma classe
        e acessados por meio das propriedades get/set
            - as propriedades fornecem um nível de abstração que permite alterar os campos sem afetar
              a maneira externa como eles são acessados por quem for utilizar a classe

    STRUCT:
        tipo de valor que pode encapsular dados e funcionalidade relacionadas, parecido com uma classe

    CLASSE X STRUCT:
        struct é um tipo de valor, enquanto classe é um tipo de referência, assim os objetos criados a partir
        de uma struct são alocados na stack e os da classe na heap

    ENUM:
        tipo de valor definido por um conjunto de constantes nomeadas do tipo numérico integral subjacente

    MODIFICADORES DE ACESSO:
        limitam a visibilidade de seus tipos/membros, restringindo-os a apenas a quem precisa realmente acessá-los,
        assim, quanto menos visibilidade houver, menor será a probabilidade de ocorrer uma alteração indesejada,
        ou seja, menor será a chance de outras partes do sistema mudar quando alguma alteração for feita
            - PRIVATE:  só pode ser acessado de dentro da classe
            - PUBLIC: pode ser acessado de qualquer lugar no código
            - INTERNAL: só pode ser acessado a partir do assembly atual dessa classe
            - PROTECTED: só pode ser acessado por membros dessa classe e por aqueles que a herdam

    PARTIAL CLASS:
        forma de dividir a definição de uma classe em múltiplos arquivos, mas que são tratados
        como uma única classe pelo compilador

 */