﻿// Copyright (c) Alexandre Mutel. All rights reserved.
// This file is licensed under the BSD-Clause 2 license. 
// See the license.txt file in the project root for more information.
using Textamina.Markdig.Extensions;
using Textamina.Markdig.Extensions.Abbreviations;
using Textamina.Markdig.Extensions.Attributes;
using Textamina.Markdig.Extensions.CustomContainers;
using Textamina.Markdig.Extensions.DefinitionLists;
using Textamina.Markdig.Extensions.Emoji;
using Textamina.Markdig.Extensions.Footnotes;
using Textamina.Markdig.Extensions.Tables;

namespace Textamina.Markdig
{
    /// <summary>
    /// Provides extension methods for <see cref="MarkdownPipeline"/> to enable several Markdown extensions.
    /// </summary>
    public static class MarkdownExtensions
    {
        /// <summary>
        /// Uses all extensions (Pipe tables, Hardline breaks, Footnotes, Strikethrough, subscript, superscript, attributes)
        /// </summary>
        /// <param name="pipeline">The pipeline.</param>
        /// <returns>The modified pipeline</returns>
        public static MarkdownPipeline UseAllExtensions(this MarkdownPipeline pipeline)
        {
            return pipeline
                .UseAbbreviation()
                .UseDefinitionList()
                .UseCustomContainer()
                .UseGridTable()
                .UsePipeTable()
                .UseSoftlineBreakAsHardlineBreak()
                .UseFootnotes()
                .UseEmojiAndSmiley()
                .UseStrikeoutSuperAndSubScript()
                .UseAttributes(); // Must be last as it is one parser that is modifying other parsers
        }

        /// <summary>
        /// Uses the custom container extension.
        /// </summary>
        /// <param name="pipeline">The pipeline.</param>
        /// <returns>The modified pipeline</returns>
        public static MarkdownPipeline UseCustomContainer(this MarkdownPipeline pipeline)
        {
            pipeline.Extensions.AddIfNotAlready<CustomContainerExtension>();
            return pipeline;
        }

        /// <summary>
        /// Uses the custom abbreviation extension.
        /// </summary>
        /// <param name="pipeline">The pipeline.</param>
        /// <returns>The modified pipeline</returns>
        public static MarkdownPipeline UseAbbreviation(this MarkdownPipeline pipeline)
        {
            pipeline.Extensions.AddIfNotAlready<AbbreviationExtension>();
            return pipeline;
        }

        /// <summary>
        /// Uses the definition lists extension.
        /// </summary>
        /// <param name="pipeline">The pipeline.</param>
        /// <returns>The modified pipeline</returns>
        public static MarkdownPipeline UseDefinitionList(this MarkdownPipeline pipeline)
        {
            pipeline.Extensions.AddIfNotAlready<DefinitionListExtension>();
            return pipeline;
        }

        /// <summary>
        /// Uses the pipe table extension.
        /// </summary>
        /// <param name="pipeline">The pipeline.</param>
        /// <returns>The modified pipeline</returns>
        public static MarkdownPipeline UsePipeTable(this MarkdownPipeline pipeline)
        {
            pipeline.Extensions.AddIfNotAlready<PipeTableExtension>();
            return pipeline;
        }

        /// <summary>
        /// Uses the grid table extension.
        /// </summary>
        /// <param name="pipeline">The pipeline.</param>
        /// <returns>The modified pipeline</returns>
        public static MarkdownPipeline UseGridTable(this MarkdownPipeline pipeline)
        {
            pipeline.Extensions.AddIfNotAlready<GridTableExtension>();
            return pipeline;
        }

        /// <summary>
        /// Uses the footnotes extension.
        /// </summary>
        /// <param name="pipeline">The pipeline.</param>
        /// <returns>The modified pipeline</returns>
        public static MarkdownPipeline UseFootnotes(this MarkdownPipeline pipeline)
        {
            pipeline.Extensions.AddIfNotAlready<FootnoteExtension>();
            return pipeline;
        }

        /// <summary>
        /// Uses the softline break as hardline break extension
        /// </summary>
        /// <param name="pipeline">The pipeline.</param>
        /// <returns>The modified pipeline</returns>
        public static MarkdownPipeline UseSoftlineBreakAsHardlineBreak(this MarkdownPipeline pipeline)
        {
            pipeline.Extensions.AddIfNotAlready<SoftlineBreakAsHardlineExtension>();
            return pipeline;
        }

        /// <summary>
        /// Uses the strikeout superscript and subscript extensions.
        /// </summary>
        /// <param name="pipeline">The pipeline.</param>
        /// <returns>The modified pipeline</returns>
        public static MarkdownPipeline UseStrikeoutSuperAndSubScript(this MarkdownPipeline pipeline)
        {
            pipeline.Extensions.AddIfNotAlready<StrikeoutSuperAndSubScriptExtension>();
            return pipeline;
        }

        /// <summary>
        /// Uses the attributes extension.
        /// </summary>
        /// <param name="pipeline">The pipeline.</param>
        /// <returns>The modified pipeline</returns>
        public static MarkdownPipeline UseAttributes(this MarkdownPipeline pipeline)
        {
            pipeline.Extensions.AddIfNotAlready<AttributesExtension>();
            return pipeline;
        }

        /// <summary>
        /// Uses the emoji and smiley extension.
        /// </summary>
        /// <param name="pipeline">The pipeline.</param>
        /// <returns>The modified pipeline</returns>
        public static MarkdownPipeline UseEmojiAndSmiley(this MarkdownPipeline pipeline)
        {
            pipeline.Extensions.AddIfNotAlready<EmojiExtension>();
            return pipeline;
        }
    }
}