﻿using MessageCard.Builder.Objects;

namespace MessageCard.Builder
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISectionsBuilder
    {
        /// <summary>
        /// Adds a section to the builder.
        /// </summary>
        /// <param name="section"></param>
        /// <returns></returns>
        ISectionsBuilder AddSection(Section section);
    }
}