export class DivisionTeamsInformation {
  divisionName: string;
  nflDivisionTeamsInformation: TeamInformation[];
}

export class TeamInformation {
  teamName: string;
  division: string;
  players: TeamMember[];
  coaches: Coach[];
  city: string;
  state: string;
  colors: string[];
  stadiumName: string;
  //seasonSchedule: Schedule[];
  //rankingInformation: TeamRankingInformation;
}

export class TeamMember {
  firstName: string;
  lastName: string;
  age: number;
  Hheight: string;
  weight: number;
  collegeName: string;
  jerseyNumber: number;
  position: string;
}

export class Coach {
  firstName: string;
  lastName: string;
  title: string;
}
