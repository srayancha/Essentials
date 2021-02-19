using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;

using PepperDash.Essentials.Core.Config;
using PepperDash.Essentials.Core.Interfaces.Components;

namespace PepperDash.Essentials.Core.Room.Components.Habanero
{
    public class DefaultSourceBehaviour : RoomComponentBase, IDefaultSourceBehaviour
    {
        #region IActivatableComponent Members

        public BoolFeedback ActivatedFeedback
        {
            get { throw new NotImplementedException(); }
        }

        public void Activate()
        {
            RouteDefaultSourceItem()
        }

        public void Deactivate()
        {
            throw new NotImplementedException();
        }

        #endregion

        public DefaultSourceBehaviour(string key, IComponentRoom parent, DeviceConfig config)
            : base(key, parent)
        {

        }

        /// <summary>
        /// Routes the default source list item
        /// </summary>
        /// <param name="source"></param>
        private void RouteDefaultSourceItem(SourceListItem sourceItem)
        {
            // gets the behaviour from the parent room that implement IRoomRoutingBehaviour
            // Calls the appropriate method and passes in the source
        }



    }


}