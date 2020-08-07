using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RulesEngine.Model;
using RulesEngine.Rules;

namespace RulesEngine
{
    class Program
    {
        static void Main(string[] args)
    {
            Registration register = new Registration();

            IRuleEngine<Registration> ruleEngine = RuleEngineFactory<Registration>.GetEngine();

            //assign the value to  register.PaymentForPhysicalProduct else it will consider as the rule is broken and it will alert the error message.
            //"PaymentForPhysicalProduct" is hardcoded. This value can be map from config file also
            register.PaymentForPhysicalProduct = "PaymentForPhysicalProduct";

            //assign the value to  register.PaymentForBook else it will consider as the rule is broken and it will alert the error message.
            //"PaymentForBook" is hardcoded. This value can be map from config file also
            register.PaymentForBook = "PaymentForBook";

            //assign the value to  register.PaymentForMembership else it will consider as the rule is broken and it will alert the error message.
            //"PaymentForMembership" is hardcoded. This value can be map from config file also
            register.PaymentForMembership = "PaymentForMembership";

            //assign the value to  register.PaymentForUpgradeToMembership else it will consider as the rule is broken and it will alert the error message.
            //"PaymentForUpgradeToMembership" is hardcoded. This value can be map from config file also
            register.PaymentForUpgradeToMembership = "PaymentForUpgradeToMembership";

            //assign the value to  register.paymentForMembershipORUpgrade else it will consider as the rule is broken and it will alert the error message.
            //"paymentForMembershipORUpgrade" is hardcoded. This value can be map from config file also
            register.paymentForMembershipORUpgrade = "paymentForMembershipORUpgrade";

            //assign the value to  register.paymentForThevideoLearningToSkip else it will consider as the rule is broken and it will alert the error message.
            //"paymentForThevideoLearningToSkip" is hardcoded. This value can be map from config file also
            register.paymentForThevideoLearningToSkip = "paymentForThevideoLearningToSkip";

            //assign the value to  register.paymentIsForPhysicalProductOrABook else it will consider as the rule is broken and it will alert the error message.
            //"paymentIsForPhysicalProductOrABook" is hardcoded. This value can be map from config file also
            register.paymentIsForPhysicalProductOrABook = "paymentIsForPhysicalProductOrABook";

            var results = ruleEngine.Validate(register);

            foreach (var r in results)
            {
                if (r.IsBroken)
                {
                    Console.WriteLine("{0} rule is broken and the error is {1}", r.Name, r.ErrorMessage);
                }
            }

            Console.Read();
        }
    }
}
