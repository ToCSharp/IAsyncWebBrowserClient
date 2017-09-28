// Copyright (c) Oleg Zudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// This file is based on or incorporates material from the project Selenium, licensed under the Apache License, Version 2.0. More info in THIRD-PARTY-NOTICES file.

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Zu.WebBrowser.BasicTypes;

namespace Zu.WebBrowser.AsyncInteractions
{
    /// <summary>
    /// Interface allowing execution of W3C Specification-compliant actions.
    /// </summary>
    public interface IActionExecutor
    {
        /// <summary>
        /// Gets a value indicating whether this object is a valid action executor.
        /// </summary>
        Task<bool> IsActionExecutor(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Performs the specified list of actions with this action executor.
        /// </summary>
        /// <param name="actionSequenceList">The list of action sequences to perform.</param>
        Task PerformActions(IList<ActionSequence> actionSequenceList, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Resets the input state of the action executor.
        /// </summary>
        Task ResetInputState(CancellationToken cancellationToken = default(CancellationToken));
    }
}
