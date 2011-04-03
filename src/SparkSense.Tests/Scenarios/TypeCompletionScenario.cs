﻿using System.Collections.Generic;
using Microsoft.VisualStudio.Language.Intellisense;
using SparkSense.Parser;

namespace SparkSense.Tests.Scenarios
{
    public class TypeCompletionScenario : TypeResolutionScenario
    {
        protected IEnumerable<Completion> TheCompletionList { get; private set; }

        protected void WhenTriggeringAnInitialCompletion()
        {
            WhenTriggeringACompletion(string.Empty);
        }

        protected void WhenTriggeringACompletion(string codeSnippit)
        {
            var completionBuilder = new CompletionBuilder(TheTypeNavigator);
            WhenLookingUpTriggerTypes();
            TheCompletionList = completionBuilder.ToCompletionList(codeSnippit);            
        }
    }
}