﻿using System;
using ICSharpCode.AvalonEdit.CodeCompletion;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Editing;

namespace PowerShellConsole
{
    public class MyCompletionData : ICompletionData
    {
        public string ToolTip { get; set; }
        public string CompletionText { get; set; }

        public System.Windows.Media.ImageSource Image
        {
            get { return null; }
        }

        public string Text
        {
            get
            {
                return CompletionText;
            }            
        }

        // Use this property if you want to show a fancy UIElement in the drop down list.
        public object Content
        {
            get { return this.Text; }
        }

        public object Description
        {
            get { return this.ToolTip; }
        }

        public double Priority { get { return 0; } }

        public void Complete(TextArea textArea, ISegment completionSegment, EventArgs insertionRequestEventArgs)
        {
            textArea.Document.Replace(completionSegment, this.Text);
        }
    }
}
