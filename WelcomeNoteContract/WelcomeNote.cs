using Stratis.SmartContracts;
using System;

public class WelcomeNote : SmartContract
{
    public WelcomeNote(ISmartContractState smartContractState)
    : base(smartContractState)
    {
        this.WelcomeMessage = "Welcome to Blockchain in C# Tutorials";
    }

    private string WelcomeMessage
    {
        get
        {
            return this.PersistentState.GetString("WelcomeMessage");
        }
        set
        {
            this.PersistentState.SetString("WelcomeMessage", value);
        }
    }
    public string DisplayWelcomeNote()
    {
        return this.WelcomeMessage;
    }
}