using Recipes.API.Helpers;
using Recipes.Shared.Entities;
using Recipes.Shared.Enums;

namespace Recipes.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;

        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckRolesAsync();
            await CheckUserAsync("admin", "1", "admin@gmail.com", UserType.Admin);
            await CheckCategoriesAsync();
            await CheckRecipesAsync();
            await CheckIngredientsAsync();
            await CheckIngredientRecipesAsync();
            await CheckRecipeCategoriesAsync();
            await CheckStepAsync();
        }

        private async Task<User> CheckUserAsync(string Name, string lastName, string email, UserType userType)
        {
            var user = await _userHelper.GetUserAsync(email);
            if (user == null)
            {
                user = new User
                {
                    Name = Name,
                    LastName = lastName,
                    Email = email,
                    UserName = email,
                    UserType = userType,
                };

                await _userHelper.AddUserAsync(user, "123456");
                await _userHelper.AddUserToRoleAsync(user, userType.ToString());
            }

            return user;
        }

        private async Task CheckCategoriesAsync()
        {
            if (!_context.Categories.Any())
            {
                _context.Categories.Add(new Category { Name = "Aperitivos", Type = "Category"});
                _context.Categories.Add(new Category { Name = "Panes y masas", Type = "Category" });
                _context.Categories.Add(new Category { Name = "Repostería", Type = "Category" });
                _context.Categories.Add(new Category { Name = "Carnes y aves", Type = "Category" });
                _context.Categories.Add(new Category { Name = "Pastas", Type = "Category" });
                _context.Categories.Add(new Category { Name = "Pescado y marisco", Type = "Category" });
                _context.Categories.Add(new Category { Name = "Verduras y hortalizas", Type = "Category" });
                _context.Categories.Add(new Category { Name = "Ensaladas", Type = "Category" });
                _context.Categories.Add(new Category { Name = "Legumbres y guisos", Type = "Category" });
                _context.Categories.Add(new Category { Name = "Navidad", Type = "Tag" });
                _context.Categories.Add(new Category { Name = "Saludable", Type = "Tag" });
                _context.Categories.Add(new Category { Name = "Al horno", Type = "Tag" });
                _context.Categories.Add(new Category { Name = "Veganas", Type = "Tag" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckRecipesAsync()
        {
            if (!_context.Recipes.Any())
            {
                // Recetas
                _context.Recipes.Add(new Recipe { 
                    Name = "Torta de almendras", 
                    Description = "El otoño siempre nos deja un montón de oportunidades para preparar unas cuantas recetas con castañas. Para muchos, esta es una de las mejores épocas del año porque podemos aprovechar para preparar todos esos postres que tanto nos gustan, desde una rica tarta de San Martiño, hasta el delicioso Marrón Glacé, esa deliciosa receta gallega de castañas en almíbar.\r\n\r\nHoy los tiros van también por el norte, porque es que os traemos un bizcocho de castañas gallegas espectacular, con un glaseado de chocolate que dejará a todos vuestros comensales con la baba colgando. Esta receta de postre es una opción genial para coronar una buena comida.\r\n\r\nEs difícil encontrar a gente a la que no le gusten las castañas, pero es más difícil aún si hablamos de castañas gallegas, una variedad de muy buena calidad, súper dulcecita y un clásico en el Magosto. Da igual que las preparemos asadas o cocidas, las castañas gallegas siempre dan buen resultado. Esto se ve reflejado en la presencia que tienen las castañas gallegas en las cocinas de grandes cocineros, donde cada vez es más difícil dar cuenta de su ausencia.\r\n\r\n", 
                    Difficulty = "Difícil",
                    ImageUrl = "https://cdn.recetasderechupete.com/wp-content/uploads/2022/12/Tarta-de-castanas-con-glaseado-de-chocolate-3-1200x828.jpg", 
                    Portions = 10, 
                    Time = 130,
                    Date = DateTime.Now
                });

                _context.Recipes.Add(new Recipe
                {
                    Name = "PASTEL DE YOGURT",
                    Description = "El pastel de yogur es un postre sencillo pero delicioso que se ha ganado un lugar especial en la repostería de muchas culturas alrededor del mundo. Esta humilde creación destaca por su suavidad, humedad y sabor equilibrado.\r\n\r\nLo que distingue al pastel de yogur es su textura excepcionalmente húmeda y esponjosa, haciéndolo suave y agradable al paladar. Es perfecto como postre, pero también es una excelente alternativa para la hora del té. Además debo mencionar, la preparación es bastante fácil.",
                    Difficulty = "Facil",
                    ImageUrl = "https://www.midiariodecocina.com/wp-content/uploads/2023/10/Pastel-de-yogurt01.jpg",
                    Portions = 10,
                    Time = 50,
                    Date = DateTime.Now
                });

                _context.Recipes.Add(new Recipe
                {
                    Name = "HELADO DE ARÁNDANOS Y CRUMBLE",
                    Description = "Sin duda la temporada oficial de los helados es el verano, pero podemos hacer excepciones con este maravilloso Helado de arándanos y crumble, en cualquier época del año, realmente una delicia con un sabor increíble y una textura diferente. Son esas recetas para lucirse con la familia o amigos.\r\n\r\nUna buenísima alternativa de postre para finalizar un almuerzo o cena especial, y si lo conserva de manera adecuada una rica opción para darse gustitos a mediados de semana. Lo rico que de esta receta es que se realiza con ingredientes fáciles de encontrar, además no necesita la clásica máquina para hacer este helado. Pueden usar arándanos frescos o congelados.\r\n\r\nEsta es una buena opción si participa en la Divina Comida.",
                    Difficulty = "Difícil",
                    ImageUrl = "https://www.midiariodecocina.com/wp-content/uploads/2022/10/Helado-de-ara%CC%81ndanos-y-crumble04.jpg",
                    Portions = 6,
                    Time = 14,
                    Date = DateTime.Now
                });

                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckIngredientsAsync()
        {
            if (!_context.Ingredients.Any())
            {
                // Ingredientes
                _context.Ingredients.Add(new Ingredient { Name = "Castañas gallegas" });
                _context.Ingredients.Add(new Ingredient { Name = "Harina de almendras" });
                _context.Ingredients.Add(new Ingredient { Name = "Huevos" });
                _context.Ingredients.Add(new Ingredient { Name = "Azúcar moreno" });
                _context.Ingredients.Add(new Ingredient { Name = "Azúcar blanco" });
                _context.Ingredients.Add(new Ingredient { Name = "Polvo de hornear" });
                _context.Ingredients.Add(new Ingredient { Name = "Sal" });
                _context.Ingredients.Add(new Ingredient { Name = "Leche entera" });
                _context.Ingredients.Add(new Ingredient { Name = "Anís estrellado" });
                _context.Ingredients.Add(new Ingredient { Name = "Chocolate negro" });
                _context.Ingredients.Add(new Ingredient { Name = "Crema de leche" });
                _context.Ingredients.Add(new Ingredient { Name = "Mantequilla sin sal" });
                _context.Ingredients.Add(new Ingredient { Name = "Agua" });

                await _context.SaveChangesAsync();
            }
        }
        private async Task CheckIngredientRecipesAsync()
        {
            if (!_context.IngredientRecipes.Any())
            {
                // Relacion de ingredientes con receta
                _context.IngredientRecipes.Add(new IngredientRecipe { Quantity = "500 g", RecipeId = 1, IngredientId = 1 });
                _context.IngredientRecipes.Add(new IngredientRecipe { Quantity = "150 g", RecipeId = 1, IngredientId = 2 });
                _context.IngredientRecipes.Add(new IngredientRecipe { Quantity = "6", RecipeId = 1, IngredientId = 3 });
                _context.IngredientRecipes.Add(new IngredientRecipe { Quantity = "100 g", RecipeId = 1, IngredientId = 4 });
                _context.IngredientRecipes.Add(new IngredientRecipe { Quantity = "50 g", RecipeId = 1, IngredientId = 5 });
                _context.IngredientRecipes.Add(new IngredientRecipe { Quantity = "16 g", RecipeId = 1, IngredientId = 6 });
                _context.IngredientRecipes.Add(new IngredientRecipe { Quantity = "3 g", RecipeId = 1, IngredientId = 7 });
                _context.IngredientRecipes.Add(new IngredientRecipe { Quantity = "20 ml", RecipeId = 1, IngredientId = 8 });
                _context.IngredientRecipes.Add(new IngredientRecipe { Quantity = "1", RecipeId = 1, IngredientId = 9 });
                _context.IngredientRecipes.Add(new IngredientRecipe { Quantity = "120 g", RecipeId = 1, IngredientId = 10 });
                _context.IngredientRecipes.Add(new IngredientRecipe { Quantity = "100 ml", RecipeId = 1, IngredientId = 11 });
                _context.IngredientRecipes.Add(new IngredientRecipe { Quantity = "25 g", RecipeId = 1, IngredientId = 12 });
                _context.IngredientRecipes.Add(new IngredientRecipe { Quantity = "30 ml", RecipeId = 1, IngredientId = 13 });

                await _context.SaveChangesAsync();
            }
        }
        private async Task CheckRecipeCategoriesAsync()
        {
            if (!_context.RecipeCategories.Any())
            {
                // Relacion de categoria y recetas
                _context.RecipeCategories.Add(new RecipeCategory { RecipeId = 1, CategoryId = 10 });
                _context.RecipeCategories.Add(new RecipeCategory { RecipeId = 1, CategoryId = 3 });
                _context.RecipeCategories.Add(new RecipeCategory { RecipeId = 2, CategoryId = 3 });
                _context.RecipeCategories.Add(new RecipeCategory { RecipeId = 3, CategoryId = 3 });

                await _context.SaveChangesAsync();
            }
        }
        private async Task CheckStepAsync()
        {
            if (!_context.Steps.Any())
            {
                // Pasos de receta
                _context.Steps.Add(new Step { RecipeId = 1, Order = 1, ImageUrl = "https://cdn.recetasderechupete.com/wp-content/uploads/2023/10/Bizcocho-de-castanas-y-almendra-paso-1.png", Description = "Lo primero que haremos será precalentar el horno a 180º C. Mientras se calienta, pelamos las castañas y las cocemos junto al anís estrellado. Cuando tengamos las castañas listas, les quitamos esa segunda piel aun en caliente, siendo bien cuidadosos de no quemarnos." });
                _context.Steps.Add(new Step { RecipeId = 1, Order = 2, ImageUrl = "", Description = "Las aplastamos con un tenedor y las dejamos reservadas para utilizarlas después. No hace falta ser súper insistentes aplastando, si quedan trocitos de castaña en el bizcocho le darán un toque de sabor interesante." });
                _context.Steps.Add(new Step { RecipeId = 1, Order = 3, ImageUrl = "", Description = "Ahora toca separar las claras. Una vez lo tengamos, batimos las claras a punto de nieve. Para ver cómo hacer este paso correctamente, podéis consultar esta entrada del blog." });
                _context.Steps.Add(new Step { RecipeId = 1, Order = 4, ImageUrl = "https://cdn.recetasderechupete.com/wp-content/uploads/2023/10/Bizcocho-de-castanas-y-almendra-paso-3.png", Description = "Lo siguiente será preparar un bol para batir la mantequilla, que deberá estar atemperada, junto al azúcar blanco y el moreno y un chorrito de leche para dar cremosidad a la mezcla. Cuando tengamos una mezcla cremosita, añadimos las seis yemas de huevo que habíamos dejado apartadas una por una y vamos removiendo hasta conseguir que se integren bien los ingredientes. Cuando tengamos una mezcla homogénea, echamos un pellizco de sal." });
                _context.Steps.Add(new Step { RecipeId = 1, Order = 5, ImageUrl = "", Description = "Ahora uniremos las claras a la mezcla usando una espátula envolviendo bien todo para evitar que la espuma pierda aire. Después, añadiremos las castañas machacadas, la harina de almendras, una pizca de sal y realizaremos también esos movimientos envolventes. Cuando se vaya integrando, añadimos la levadura. Ya tenemos la masa del bizcocho lista para hornear." });
                _context.Steps.Add(new Step { RecipeId = 1, Order = 6, ImageUrl = "https://cdn.recetasderechupete.com/wp-content/uploads/2023/10/Bizcocho-de-castanas-y-almendra-paso-4-1200x370.png", Description = "Preparamos un molde de silicona para el bizcocho de unos 23 cm. de diámetro. Aunque se puede usar un molde más grande de 24 centímetros, pero quedará un poco más baja. En casa tenemos este tipo de molde porque es muy fácil luego desmoldar el bizcocho, pero si no tenemos podemos usar otro, pero es conveniente enmantecarlo para que no se pegue." });
                _context.Steps.Add(new Step { RecipeId = 1, Order = 7, ImageUrl = "", Description = "Espolvoreamos un poco la base con azúcar y cuando lo tengamos listo, echamos la mezcla que tenemos preparada." });
                _context.Steps.Add(new Step { RecipeId = 1, Order = 8, ImageUrl = "", Description = "Lo siguiente es hornear el bizcocho alrededor de una hora. Los tiempos dependen de cada horno. El truco para saber que está listo es pincharlo con un palillo y, si sale seco, es hora de apagar el horno. Después, lo dejaremos enfriar en el mismo horno diez minutos con la puerta abierta y el horno apagado. Ya tendremos el bizcocho listo para preparar el glaseado de chocolate." });
                _context.Steps.Add(new Step { RecipeId = 1, Order = 9, ImageUrl = "", Description = "Lo primero que haremos será trocear el chocolate con un cuchillo que tengamos bien afilado. Hay que partirlo en trocitos muy pequeñitos. Aprovechamos para trocear también la mantequilla." });
                _context.Steps.Add(new Step { RecipeId = 1, Order = 10, ImageUrl = "https://cdn.recetasderechupete.com/wp-content/uploads/2022/12/Verter-chocolate-en-la-tarta-Sacher-1.jpg", Description = "Colocaremos el bizcocho sobre una rejilla, poniendo un plato grande o una bandeja bajo esta. El glaseado desbordará el bizcocho por los lados, así que, si no queremos manchar mucho, esto es importante." });
                _context.Steps.Add(new Step { RecipeId = 1, Order = 11, ImageUrl = "", Description = "Ponemos la nata en un cazo a calentar hasta que empiece a hervir. Una vez haya alcanzado la ebullición, retiramos del fuego y añadimos el chocolate que habíamos picado previamente. Ahora toca remover bien el chocolate y la nata con una espátula para lograr que se funda todo." });
                _context.Steps.Add(new Step { RecipeId = 1, Order = 12, ImageUrl = "", Description = "Cuando empiece a fundirse, añadimos también la mantequilla, y removemos de manera constante para evitar que se nos formen grumitos en el chocolate." });
                _context.Steps.Add(new Step { RecipeId = 1, Order = 13, ImageUrl = "", Description = "El truco final está en añadir dos cucharadas de agua y remover bien rápido, tratando de que se integren bien todos los ingredientes." });
                _context.Steps.Add(new Step { RecipeId = 1, Order = 14, ImageUrl = "", Description = "Con esto, ya tendremos listo el glaseado. Lo que queda es echarlo del cazo por encima de nuestro bizcocho en el centro e ir dejando que vaya cayendo poquito a poco por los lados. Cuando hayamos vertido todo el chocolate, utilizaremos una espátula para extender en los lugares que no se hayan cubierto del todo." });
                _context.Steps.Add(new Step { RecipeId = 1, Order = 15, ImageUrl = "https://cdn.recetasderechupete.com/wp-content/uploads/2022/12/Tarta-de-castanas-con-glaseado-de-chocolate.jpg", Description = "Ahora hay que dejar que se enfríe bien para que el glaseado quede seco y súper rico. Para esto, un buen truco es dejarlo media hora en la nevera. Una vez haya enfriado, nuestro bizcocho de castañas gallegas y almendras con glaseado de chocolate lo podemos decorar al gusto. En este caso con un poco de almendras y castañas en granillo, una hojita de hierbabuena para dar color y ya está listo para comer. ¡Qué aproveche!" });

                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckRolesAsync()
        {
            await _userHelper.CheckRoleAsync(UserType.Admin.ToString());
            await _userHelper.CheckRoleAsync(UserType.User.ToString());
        }

    }
}
