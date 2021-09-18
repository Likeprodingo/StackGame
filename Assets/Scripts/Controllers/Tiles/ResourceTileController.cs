using UnityEngine;

namespace DefaultNamespace
{
    public class ResourceTileController : DepletingTileController
    {

        #region Public

        #endregion

        #region Unity

        #endregion

        #region Action

        #endregion

        #region Private

        public override void Process()
        {
            Destroy(this);
        }

        #endregion
    }
}