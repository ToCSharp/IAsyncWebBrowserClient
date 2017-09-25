// Copyright (c) Oleg Zudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// This file is based on or incorporates material from the project Selenium, licensed under the Apache License, Version 2.0. More info in THIRD-PARTY-NOTICES file.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Zu.WebBrowser.BasicTypes
{
    /// <summary>
    /// Represents a sequence of actions to be performed in the target browser.
    /// </summary>
    public class ActionSequence
    {
        public List<Interaction> Interactions { get; set; } = new List<Interaction>();
        public InputDevice Device { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionSequence"/> class.
        /// </summary>
        /// <param name="device">The input device that executes this sequence of actions.</param>
        /// <param name="initialSize">the initial size of the sequence.</param>
        public ActionSequence(InputDevice device, int initialSize = 0)
        {
            if (device == null)
            {
                throw new ArgumentNullException("device", "Input device cannot be null.");
            }

            this.Device = device;

            for (int i = 0; i < initialSize; i++)
            {
                this.AddAction(new PauseInteraction(device, TimeSpan.Zero));
            }
        }

        /// <summary>
        /// Gets the count of actions in the sequence.
        /// </summary>
        public int Count
        {
            get { return this.Interactions.Count; }
        }

        /// <summary>
        /// Adds an action to the sequence.
        /// </summary>
        /// <param name="interactionToAdd">The action to add to the sequence.</param>
        /// <returns>A self-reference to this sequence of actions.</returns>
        public ActionSequence AddAction(Interaction interactionToAdd)
        {
            if (interactionToAdd == null)
            {
                throw new ArgumentNullException("interactionToAdd", "Interaction to add to sequence must not be null");
            }

            if (!interactionToAdd.IsValidFor(this.Device.DeviceKind))
            {
                throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "Interaction {0} is invalid for device type {1}.", interactionToAdd.GetType(), this.Device.DeviceKind), "interactionToAdd");
            }

            this.Interactions.Add(interactionToAdd);
            return this;
        }

        /// <summary>
        /// Converts this action sequence into an object suitable for serializing across the wire.
        /// </summary>
        /// <returns>A <see cref="Dictionary{TKey, TValue}"/> containing the actions in this sequence.</returns>
        public Dictionary<string, object> ToDictionary()
        {
            Dictionary<string, object> toReturn = this.Device.ToDictionary();

            List<object> encodedActions = new List<object>();
            foreach (Interaction action in this.Interactions)
            {
                encodedActions.Add(action.ToDictionary());
            }

            toReturn["actions"] = encodedActions;

            return toReturn;
        }

        /// <summary>
        /// Returns a string that represents the current <see cref="ActionSequence"/>.
        /// </summary>
        /// <returns>A string that represents the current <see cref="ActionSequence"/>.</returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder("Action sequence - ").Append(this.Device.ToString());
            foreach (Interaction action in this.Interactions)
            {
                builder.AppendLine();
                builder.AppendFormat("    {0}", action.ToString());
            }

            return builder.ToString();
        }
    }
}
