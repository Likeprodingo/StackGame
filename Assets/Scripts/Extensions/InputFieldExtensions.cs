using UnityEngine;
using UnityEngine.UI;

namespace Extensions
{
    public static class InputFieldExtensions
    {
        #region Public

        public static void Focus(this InputField input, int characterLimit = 10)
        {
            TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false, false, false, false,
                input.text, 10);
            input.Select();
            input.ActivateInputField();
            TouchScreenKeyboard.hideInput = true;
        }
        
        #endregion
    }
}