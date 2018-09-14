  void Start()
    {
        // Estado do Cursor = Travado
        Cursor.lockState = CursorLockMode.Locked;
        
        // Deixa o Cursor invisivel
        Cursor.visible = false;
    }
   
    // void Voltar o Foco (aplicacaoVoltou [bool value])
    void OnApplicationFocus(bool ApplicationIsBack)
    {
        // se (aplicacaoVoltou [do alt-tab] == true)
        if (ApplicationIsBack == true)
        {
            // refaz a operação Start()
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
