﻿namespace AdaptiveTriggerLibrary.ConditionModifiers.ComparableModifiers
{
    using System;

    public class NotEqualToModifier : IComparableModifier
    {
        ///////////////////////////////////////////////////////////////////
        #region IConditionModifier<IComparable> Members

        public bool IsConditionMet(IComparable value, IComparable condition)
        {
            return !Equals(value, condition);
        }

        #endregion
    }
}