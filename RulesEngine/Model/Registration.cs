using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RulesEngine.Rules;

namespace RulesEngine.Model
{
    [RuleEngineType(RuleType = typeof(DefaultRuleEngine<Registration>))]
    public class Registration
    {
        
        [RequiredField("payment is for a physical product", "generate a packing slip for shipping")]
        public string PaymentForPhysicalProduct { get; set; }

        [RequiredField("payment is for a book","create a duplicate packing slip for the royalty department")]
        public string PaymentForBook { get; set; }

        [RequiredField("payment is for a membership", "activate that membership")]
        public string PaymentForMembership { get; set; }

        [RequiredField("payment is an upgrade to a membership"," apply the upgrade")]
        public string PaymentForUpgradeToMembership { get; set;}

        [RequiredField("payment is for a membership or upgrade"," e-mail the owner and inform them of the activation/upgrade")]
        public string paymentForMembershipORUpgrade { get; set;}

        [RequiredField("payment is for the video “Learning to Ski","add a free First Aid video to the packing slip (the result of a court decision in 1997)")]
        public string paymentForThevideoLearningToSkip { get; set; }

        [RequiredField("payment is for a physical product or a book"," generate a commission payment to the agent")]
        public string paymentIsForPhysicalProductOrABook { get; set; }

    }
}
