using WineRack.Shared.Models.Winery;

namespace WineRack.Application.Profiles;

public class WineryProfiles : Profile
{
	public WineryProfiles()
	{
		CreateMap<WineryCountry, WineryFullVM>()
			.ForMember(dest => dest.WineryName, opts => opts.MapFrom(src => src.Winery.Name))
			.ForMember(dest => dest.Country, opts => opts.MapFrom(src => src.Country.CountryName))
			.ForMember(dest => dest.Bottles, opts => opts.MapFrom(src => src.Winery.Bottles));

	}
}
