﻿using FireBrowserDataCore.Actions.Contracts;
using FireBrowserDataCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace FireBrowserDataCore.Actions
{

    public class DownloadActions : IDownloadActions
    {
        public DownloadContext DownloadContext { get; set; }

        public DownloadActions(string username)
        {

            DownloadContext = new DownloadContext(username);

        }

        public async Task InsertDownloadItem(string guid, string current_path, string end_time, long start_time)
        {

            try
            {
                await DownloadContext.Downloads.AddAsync(new DownloadItem(guid, current_path, end_time, start_time));
                await DownloadContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inserting downloaded item: {ex.Message}");
            }
        }

        public async Task DeleteDownloadItem(string current_path)
        {

            try
            {

                await DownloadContext.Downloads.Where(x => x.current_path == current_path).ExecuteDeleteAsync();
                await DownloadContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting download item: {ex.Message}");
            }
        }

    }
}
