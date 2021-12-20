namespace Book.Tests
{
    using System;

    using NUnit.Framework;

    public class Tests
    {

        private Book book;

        [SetUp]
        public void SetUp()
        {
            book = new Book("LordOfTheRings", "J.R.R. Tolkien");
        }

        [Test]
        public void InitializeCostructorProperly()
        {
            Assert.AreEqual("LordOfTheRings", book.BookName);
            Assert.AreEqual("J.R.R. Tolkien", book.Author);
            Assert.AreEqual(0, book.FootnoteCount);
        }

        [Test]
        public void AuthroSetProperly()
        {
            Assert.Throws<ArgumentException>(() => new Book(null, "J.R.R. Tolkien"));
        }

        [Test]
        public void BookNameSetProperly()
        {
            Assert.Throws<ArgumentException>(() => new Book("LordOfTheRings", null));
        }

        [Test]
        public void AddFootnoteThrowInvalidOperationException()
        {
            book.AddFootnote(1, "FirstChapter");
            Assert.Throws<InvalidOperationException>(() => book.AddFootnote(1, "FirstChapter"));
        }

        [Test]
        public void AddFootnoteWorkProperly()
        {
            book.AddFootnote(1, "FirstChapter");
            book.AddFootnote(1 + 1, "FirstChapter" + "SecondChapter");

            Assert.AreEqual(2, book.FootnoteCount);
        }

        [Test]
        public void FindFootnoteThrowInvalidOperationException()
        {
            book.AddFootnote(1, "FirstChapter");

            Assert.Throws<InvalidOperationException>(() => book.FindFootnote(1 + 1));
        }

        [Test]
        public void FindFootnoteWorkProperly()
        {
            book.AddFootnote(1, "FirstChapter");
            book.AddFootnote(1 + 1, "FirstChapter" + "SecondChapter");

            Assert.AreEqual($"Footnote #{1}: {"FirstChapter"}", book.FindFootnote(1));
        }

        [Test]
        public void AlterFootnoteWorkProperly()
        {
            book.AddFootnote(1, "FirstChapter");
            book.AddFootnote(1 + 1, "FirstChapter" + "SecondChapter");
            string footNoteResult = book.FindFootnote(1);
            string actualResult = "Footnote #1: FirstChapter";
            book.AlterFootnote(1, "Alter text of the first footnote");

            string footNoteResultAftetChange = book.FindFootnote(1);
            string actualResultAfterChange = "Footnote #1: Alter text of the first footnote";

            Assert.AreEqual(footNoteResult, actualResult);
            Assert.AreEqual(footNoteResultAftetChange, actualResultAfterChange);
        }

        [Test]
        public void AlterFootnoteThrowsInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => book.AlterFootnote(1, "Gandalf"));
        }
    }
}