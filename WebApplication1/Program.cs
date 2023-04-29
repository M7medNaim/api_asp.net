using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.MapGet("/", () =>Results.Json("Blog!"));

app.MapGet("/api/Posts", () =>
{
    return Results.Ok(Data.Posts);
});

app.MapGet("/api/Posts/{id}" , (int id) =>
{
    var post = Data.Posts.FirstOrDefault(p => p.Id == id);
    if (post is null)
        return Results.NotFound(new
        {
            Message = "Post Not Found"
        });
    

        return Results.Ok(post);
    
});

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();


//app.MapPost("api/Posts" , ([FromBody] )=>{
//    Data.Posts.Add(newPost);
//});

app.Run();
