using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPractice.TechInterview
{

    public abstract class TechInterview
    {
        public static string AskQuestion()
        {
            return "What is Encryption?";
        }
    }

    public class Hussein : TechInterview
    {
        public static string AskQuestion()
        {
            return "Please tell me more about andela";
        }

        
    }

    


    public class HussainTask
    {
    }

    //Liskov Substitution Principle
    //This principle states that, if S is a subtype of T, then objects of
    //type T should be replaced with the objects of type S.

    //Using Liskov Substitution Principle, Display the transaction charges for three account types
    //Savings, Current and Domiciliary Account.


    public interface IBankAccountType
    {
       float GetTransctionCharge();
    }


    public class SavingsAccountType : IBankAccountType
    {
        public float GetTransctionCharge()
        {
            return 6.00F;
        }
    }

    public class CurrentAccountType : IBankAccountType
    {
        public float GetTransctionCharge()
        {
            return 5.00F;
        }
    }



    
    public abstract class AccountType
    {
        public abstract float GetTransctionCharge();
    }

    public  class Savings : AccountType
    {
        public override float GetTransctionCharge()
        {
            return 3.00F;
        }
    }

    public class Current : AccountType
    {
        public override float GetTransctionCharge()
        {
            return 5.00F;
        }
    }

    public  class DomiciliaryAccount: AccountType
    {
        public override float GetTransctionCharge()
        {
            return 10.0F;
        }
    }

    //Questions
    //1. What is the difference between an abstract class and an interface
    //2. 
}
