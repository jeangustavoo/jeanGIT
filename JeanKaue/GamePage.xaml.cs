namespace JeanKaue;

public partial class GamePage : ContentPage
{
    
  List<HistoryStep> historia = new List<HistoryStep>();
  HistoryStep HistoryStepAtual;

  public GamePage()
	{
		InitializeComponent();

    historia.Add(new HistoryStep()
    {
 Id = 0,
      Texto = "Salve jogador, parece que você quer ter uma carreira brilhante pela frente, então vamos começar?",
      TemResposta=false
    });
    historia.Add(new HistoryStep()
    {
      Id = 1,
      Texto = "Em qual time você desejar começar sua carreira?",
      TemResposta=true,
      TextoDaResposta01="Bahia",
      TextoDaResposta02="Santos",
      TextoDaResposta03="Vasco",
      IdLevelResposta01=2,
      IdLevelResposta02=998,
      IdLevelResposta03=999,
    });
     historia.Add(new HistoryStep()
    {
      Id = 2,
      Texto = "Você entrou em um time em ascenção, será que tornará um grande idolo?",
      TemResposta=false,
    });
    historia.Add(new HistoryStep()
    {
      Id = 3,
      Texto = "Você recebeu uma proposta de um time asiático, com um enorme salário, você deseja fazer essa troca?",
      TemResposta=true,
      TextoDaResposta01="Não, desejo continuar no Bahia",
      TextoDaResposta02="Sim, desejo receber um salário melhor!",
      IdLevelResposta01=4,
      IdLevelResposta02=998,
    });
    historia.Add(new HistoryStep()
    {
      Id = 4,
      Texto = "Você fez a escolha certa, virou um dos maiores idolos no Bahia, ganhou varios titulos importantes para o clube. Parabens jogador! Mas chegou a hora de se aposentar, como você deseja que isso seja?",
      TemResposta=true,
      TextoDaResposta01="Um jogo de despedida",
      TextoDaResposta02="Entrar para a diretoria do time",
      TextoDaResposta03="Não se aposentar e tentar salvar o ABC do rebaixamento.",
      IdLevelResposta01=1000,
      IdLevelResposta02=1000,
      IdLevelResposta03=998,

    });
     historia.Add(new HistoryStep()
    {
      Id = 998,
      Texto = "Seu time caiu!",
      TemResposta=false,
      aposentadoriajogador=true

    });
     historia.Add(new HistoryStep()
    {
      Id = 999,
      Texto = "Seu time faliu e sua carreira acabou!",
      TemResposta=false,
      aposentadoriajogador=true

    });
     historia.Add(new HistoryStep()
    {
      Id = 1000,
      Texto = "APOSENTOU!!!",
      aposentadoriajogador=true
    });
    Iniciar();
	}
    void Iniciar()
  {
    TrocaHistoryStepAtual(0);
  }
  void PreencherPagina()
  {
    labelTexto.Text = HistoryStepAtual.Texto;

    if (HistoryStepAtual.aposentadoriajogador)
      frameAposentou.IsVisible = true;
    else
      frameAposentou.IsVisible = false;

    if (HistoryStepAtual.TemResposta)
    {
      buttoncontinuar.IsVisible = false;
      buttonResposta01.IsVisible = true;
      buttonResposta02.IsVisible = true;
      buttonResposta03.IsVisible = true;
      buttonResposta01.Text = HistoryStepAtual.TextoDaResposta01;
      buttonResposta02.Text = HistoryStepAtual.TextoDaResposta02;
      buttonResposta03.Text = HistoryStepAtual.TextoDaResposta03;
    }
    else
    {
      buttoncontinuar.IsVisible = true;
      buttonResposta01.IsVisible = false;
      buttonResposta02.IsVisible = false;
      buttonResposta03.IsVisible = false;
    }
  }
   void TrocaHistoryStepAtual(int id)
  {
    HistoryStepAtual = historia.Where(d => d.Id == id).First();
    PreencherPagina();
  }

    void QuandoClicarContinuar(object sender, EventArgs args)
  {
    var proximoId = HistoryStepAtual.Id + 1;
    TrocaHistoryStepAtual(proximoId);
  }

    void clicarresposta1 (object sender, EventArgs args)
  {
    TrocaHistoryStepAtual(HistoryStepAtual.IdLevelResposta01);
  }

    void clicarresposta2 (object sender, EventArgs args)
  {
    TrocaHistoryStepAtual(HistoryStepAtual.IdLevelResposta02);
  }

    void clicarresposta3 (object sender, EventArgs args)
  {
    TrocaHistoryStepAtual(HistoryStepAtual.IdLevelResposta03);
  }
    void QuandoClicarRecomeçar(object sender, EventArgs args)
  {
    Iniciar();
  }
}
