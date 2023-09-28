/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
*/

namespace QuantConnect.Orders
{
    /// <summary>
    /// The terminal link order properties
    /// </summary>
    public class TerminalLinkOrderProperties : OrderProperties
    {
        /// <summary>
        /// The EMSX Instructions is the free form instructions that may be sent to the broker
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// The EMSX Handling Instruction is the instructions for handling the order or route.The values can be
        /// preconfigured or a value customized by the broker.
        /// </summary>
        public string HandlingInstruction { get; set; }

        /// <summary>
        /// Custom user order notes 1
        /// </summary>
        public string CustomNotes1 { get; set; }

        /// <summary>
        /// Custom user order notes 2
        /// </summary>
        public string CustomNotes2 { get; set; }

        /// <summary>
        /// Custom user order notes 3
        /// </summary>
        public string CustomNotes3 { get; set; }

        /// <summary>
        /// Custom user order notes 4
        /// </summary>
        public string CustomNotes4 { get; set; }

        /// <summary>
        /// Custom user order notes 5
        /// </summary>
        public string CustomNotes5 { get; set; }
    }
}
