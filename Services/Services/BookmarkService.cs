﻿using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookmarkService : IBookmarkService
    {
        private ReadLaterDataContext _ReadLaterDataContext;
        public BookmarkService(ReadLaterDataContext readLaterDataContext) 
        {
            _ReadLaterDataContext = readLaterDataContext;            
        }

        public Bookmark CreateBookmark(Bookmark bookmark)
        {
            _ReadLaterDataContext.Add(bookmark);
            _ReadLaterDataContext.SaveChanges();
            return bookmark;
        }

        public void UpdateBookmark(Bookmark bookmark)
        {
            _ReadLaterDataContext.Update(bookmark);
            _ReadLaterDataContext.SaveChanges();
        }

        public List<Bookmark> GetBookmarks(Guid userId)
        {
            return _ReadLaterDataContext.Bookmark.Where(x => x.UserID == userId).ToList();
        }

        public Bookmark GetBookmark(int Id)
        {
            Bookmark bookmark = _ReadLaterDataContext.Bookmark.Where(c => c.ID == Id).FirstOrDefault();
            bookmark.Category = _ReadLaterDataContext.Categories.Where(x => x.ID == bookmark.CategoryId).FirstOrDefault();
            return bookmark;
        }

        public void DeleteBookmark(Bookmark bookmark)
        {
            _ReadLaterDataContext.Bookmark.Remove(bookmark);
            _ReadLaterDataContext.SaveChanges();
        }
    }
}
